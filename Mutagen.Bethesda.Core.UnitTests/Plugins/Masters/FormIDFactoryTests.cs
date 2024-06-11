﻿using FluentAssertions;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Masters;
using Mutagen.Bethesda.Plugins.Masters.DI;
using Mutagen.Bethesda.Plugins.Order;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Testing.AutoData;
using Xunit;

namespace Mutagen.Bethesda.UnitTests.Plugins.Masters;

public class FormIDFactoryTests
{
    [Theory, MutagenAutoData]
    internal void TypicalMasters(
        ModKey originating,
        ModKey modKeyA,
        ModKey modKeyB,
        Type recordType,
        FormIDFactory sut)
    {
        var coll = new MasterReferenceCollection(originating);
        coll.SetTo(new []
        {
            new MasterReference()
            {
                Master = modKeyA
            },
            new MasterReference()
            {
                Master = modKeyB
            },
        });
        var masterPackage = SeparatedMasterPackage.Factory(coll);

        sut.GetFormID(masterPackage,
                new FormLinkInformation(
                    new FormKey(modKeyA, 123), recordType))
            .Should().Be(
                new FormID(
                    new ModIndex(0),
                    123));
        
        sut.GetFormID(masterPackage,
            new FormLinkInformation(
                new FormKey(modKeyB, 456), recordType))
            .Should().Be(
                new FormID(
                    new ModIndex(1),
                    456));
        sut.GetFormID(masterPackage,
            new FormLinkInformation(
                new FormKey(originating, 789), recordType))
            .Should().Be(
                new FormID(
                    new ModIndex(2),
                    789));
    }
    
    [Theory, MutagenAutoData]
    internal void NoMasters(
        ModKey originating,
        Type recordType,
        FormIDFactory sut)
    {
        var coll = new MasterReferenceCollection(originating);
        var masterPackage = SeparatedMasterPackage.Factory(coll);

        sut.GetFormID(
            masterPackage,
            new FormLinkInformation(
                    new FormKey(originating, 789), recordType))
            .Should().Be(
                new FormID(
                    new ModIndex(0),
                    789));
    }
    
    [Theory, MutagenAutoData]
    internal void TypicalSeparateMasters(
        ModKey originating,
        ModKey modA,
        ModKey modB,
        ModKey lightA,
        ModKey lightB,
        ModKey mediumA,
        ModKey mediumB,
        Type recordType,
        FormIDFactory sut)
    {
        var coll = new MasterReferenceCollection(originating);
        coll.SetTo(new []
        {
            new MasterReference()
            {
                Master = modA
            },
            new MasterReference()
            {
                Master = lightA
            },
            new MasterReference()
            {
                Master = mediumA
            },
            new MasterReference()
            {
                Master = modB
            },
            new MasterReference()
            {
                Master = lightB
            },
            new MasterReference()
            {
                Master = mediumB
            },
        });
        var lo = new LoadOrder<IModFlagsGetter>();
        lo.Add(MastersTestUtil.GetFlags(modA, MasterStyle.Normal));
        lo.Add(MastersTestUtil.GetFlags(lightA, MasterStyle.Light));
        lo.Add(MastersTestUtil.GetFlags(mediumA, MasterStyle.Medium));
        lo.Add(MastersTestUtil.GetFlags(modB, MasterStyle.Normal));
        lo.Add(MastersTestUtil.GetFlags(lightB, MasterStyle.Light));
        lo.Add(MastersTestUtil.GetFlags(mediumB, MasterStyle.Medium));
        lo.Add(MastersTestUtil.GetFlags(originating, MasterStyle.Normal));
        var masterPackage = SeparatedMasterPackage.Factory(coll, lo);

        sut.GetFormID(masterPackage,
                new FormLinkInformation(
                    new FormKey(modA, 123), recordType))
            .Should().Be(
                new FormID(
                    new ModIndex(0),
                    123));
        sut.GetFormID(masterPackage,
                new FormLinkInformation(
                    new FormKey(modB, 456), recordType))
            .Should().Be(
                new FormID(
                    new ModIndex(1),
                    456));
        sut.GetFormID(masterPackage,
                new FormLinkInformation(
                    new FormKey(originating, 789), recordType))
            .Should().Be(
                new FormID(
                    new ModIndex(2),
                    789));
        sut.GetFormID(masterPackage,
                new FormLinkInformation(
                    new FormKey(lightA, 0x123), recordType))
            .Should().Be(
                new FormID(
                    new ModIndex(0xFE),
                    0x000123));
        sut.GetFormID(masterPackage,
                new FormLinkInformation(
                    new FormKey(lightB, 0x123), recordType))
            .Should().Be(
                new FormID(
                    new ModIndex(0xFE),
                    0x001123));
        sut.GetFormID(masterPackage,
                new FormLinkInformation(
                    new FormKey(mediumA, 0x1234), recordType))
            .Should().Be(
                new FormID(
                    new ModIndex(0xFD),
                    0x001234));
        sut.GetFormID(masterPackage,
                new FormLinkInformation(
                    new FormKey(mediumB, 0x1234), recordType))
            .Should().Be(
                new FormID(
                    new ModIndex(0xFD),
                    0x011234));
    }
    
    [Theory, MutagenAutoData]
    internal void SeparateMastersOriginatingLight(
        ModKey originating,
        ModKey modA,
        ModKey lightA,
        Type recordType,
        FormIDFactory sut)
    {
        var coll = new MasterReferenceCollection(originating);
        coll.SetTo(new []
        {
            new MasterReference()
            {
                Master = modA
            },
            new MasterReference()
            {
                Master = lightA
            },
        });
        var lo = new LoadOrder<IModFlagsGetter>();
        lo.Add(MastersTestUtil.GetFlags(modA, MasterStyle.Normal));
        lo.Add(MastersTestUtil.GetFlags(lightA, MasterStyle.Light));
        lo.Add(MastersTestUtil.GetFlags(originating, MasterStyle.Light));
        var masterPackage = SeparatedMasterPackage.Factory(coll, lo);

        sut.GetFormID(masterPackage,
                new FormLinkInformation(
                    new FormKey(modA, 123), recordType))
            .Should().Be(
                new FormID(
                    new ModIndex(0),
                    123));
        sut.GetFormID(masterPackage,
                new FormLinkInformation(
                    new FormKey(lightA, 0x123), recordType))
            .Should().Be(
                new FormID(
                    new ModIndex(0xFE),
                    0x000123));
        sut.GetFormID(masterPackage,
                new FormLinkInformation(
                    new FormKey(originating, 0x123), recordType))
            .Should().Be(
                new FormID(
                    new ModIndex(0xFE),
                    0x001123));
    }
    
    [Theory, MutagenAutoData]
    internal void SeparateMastersOriginatingMedium(
        ModKey originating,
        ModKey modA,
        ModKey mediumA,
        Type recordType,
        FormIDFactory sut)
    {
        var coll = new MasterReferenceCollection(originating);
        coll.SetTo(new []
        {
            new MasterReference()
            {
                Master = modA
            },
            new MasterReference()
            {
                Master = mediumA
            },
        });
        var lo = new LoadOrder<IModFlagsGetter>();
        lo.Add(MastersTestUtil.GetFlags(modA, MasterStyle.Normal));
        lo.Add(MastersTestUtil.GetFlags(mediumA, MasterStyle.Medium));
        lo.Add(MastersTestUtil.GetFlags(originating, MasterStyle.Medium));
        var masterPackage = SeparatedMasterPackage.Factory(coll, lo);

        sut.GetFormID(masterPackage,
                new FormLinkInformation(
                    new FormKey(modA, 123), recordType))
            .Should().Be(
                new FormID(
                    new ModIndex(0),
                    123));
        sut.GetFormID(masterPackage,
                new FormLinkInformation(
                    new FormKey(mediumA, 0x1234), recordType))
            .Should().Be(
                new FormID(
                    new ModIndex(0xFD),
                    0x001234));
        sut.GetFormID(masterPackage,
                new FormLinkInformation(
                    new FormKey(originating, 0x1234), recordType))
            .Should().Be(
                new FormID(
                    new ModIndex(0xFD),
                    0x011234));
    }
}