using BlazorWASMkit.Components;

namespace BlazorWASMkit.Services;

public sealed class ContactCatalogService
{
    private static readonly IReadOnlyDictionary<ContactGroup, IReadOnlyList<ContactLink>> Catalog =
        new Dictionary<ContactGroup, IReadOnlyList<ContactLink>>
        {
            [ContactGroup.TommiTechnik] =
            [
                new ContactLink("Tel: 722 951 416"),
                new ContactLink("Email: technik19@tommi.cz", "mailto:technik19@tommi.cz")
            ],
            [ContactGroup.TommiVoda] =
            [
                new ContactLink("Tel: 800 140 140"),
                new ContactLink("TOMMI Holding s.r.o ")
            ],
            [ContactGroup.TommiVodaMimoObjekt] =
            [
                new ContactLink("Tel: 840 111 112"),
                new ContactLink("Pražské vodovody a kanalizace")
            ],
            [ContactGroup.TommiTeplo] =
            [
                new ContactLink("Tel: 606 184 973"),
                new ContactLink("PROHEAT s.r.o.")
            ],
            [ContactGroup.TommiElektrina] =
            [
                new ContactLink("Tel: 800 823 823"),
                new ContactLink("Pražská energetika a.s.")
            ],
            [ContactGroup.TommiVytah] =
            [
                new ContactLink("Tel: 800 107 525"),
                new ContactLink("OTIS a.s.")
            ],
            [ContactGroup.TommiUcetnictvi] =
            [
                new ContactLink("Tel: 722 951 416, Jirusová"),
                new ContactLink("Email: tereza.jirusova@tommi.cz", "mailto:tereza.jirusova@tommi.cz")
            ],
            [ContactGroup.HeaterGeneral] =
            [
                new ContactLink("Tel: 603 247 682")
            ],
            [ContactGroup.HeaterPohotovost] =
            [
                new ContactLink("Tel: 606 184 973")
            ],
            [ContactGroup.MeterInfo] =
            [
                new ContactLink("Technik TOMMI")
            ],
            [ContactGroup.Svj548Contacts] =
            [
                new ContactLink("Email: jan.macecek@krit.cz", "mailto:jan.macecek@krit.cz"),
                new ContactLink("Mobil: +420 602 612 216")
            ]
        };

    public IReadOnlyList<ContactLink> Get(ContactGroup group) =>
        Catalog.TryGetValue(group, out var items)
            ? items
            : Array.Empty<ContactLink>();
}
